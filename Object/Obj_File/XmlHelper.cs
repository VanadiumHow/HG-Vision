using Model.ConstantModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Obj.Obj_File
{
    // 使用 XmlSerializer 进行序列化和反序列化的工具类
    public static class XmlHelper
    {
        // 字典缓存 XmlSerializer 实例以提高性能
        private static readonly Dictionary<Type, XmlSerializer> _serializerCache = new Dictionary<Type, XmlSerializer>();
        private static XmlSerializer GetSerializer(Type type)
        {
            if (!_serializerCache.TryGetValue(type, out var serializer))
            {
                serializer = new XmlSerializer(type);
                _serializerCache[type] = serializer;
            }
            return serializer;
        }
        // class:引用类型, new():构造函数约束
        public static T Deserialize<T>(string filePath) where T : class, new()
        {
            try
            {
                // 确保目录存在
                var directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    var _aimObj = new T(); // 文件不存在时返回新实例
                    Serialize(filePath, _aimObj);
                    return _aimObj;
                }

                var serializer = GetSerializer(typeof(T));
                T output;
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    output = (T)serializer.Deserialize(reader);
                }
                //在返回T类型的实例前，先进行一次序列化，保证若参数名修改，能够正确映射导.xml文件中（例如program改为Program）
                Serialize(filePath, output);
                return output;
            }
            catch (Exception ex)
            {
                LogHelper.Error($"反序列化XML文件失败: {filePath}", ex);
                return new T();
            }
        }

        public static void Serialize<T>(string filePath, T obj) where T : class, new()
        {
            var serializer = GetSerializer(typeof(T));
            // 确保目录存在
            var directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                serializer.Serialize(writer, obj);
            }
            //主配置文件ini
            if (!File.Exists(filePath))
                LogHelper.Error("序列化保存filePath失败，请检查文件目录与相关代码！");
        }
    }
}
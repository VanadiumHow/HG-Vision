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
                if (!File.Exists(filePath))
                {
                    LogHelper.Error($"路径文件不存在: {filePath}");
                    return new T(); // 文件不存在时返回新实例
                }

                var serializer = GetSerializer(typeof(T));
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error($"反序列化XML文件失败: {filePath}", ex);
                return new T();
            }
        }

        public static void Serialize<T>(T obj, string filePath) where T : class, new()
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
        }
    }
}
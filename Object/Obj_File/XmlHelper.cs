using System;
using System.IO;
using System.Xml.Serialization;

namespace Obj.Obj_File
{
    // 使用 XmlSerializer 进行序列化和反序列化的工具类
    public static class XmlHelper
    {
        public static T Deserialize<T>(string filePath) where T : class, new()
        {
            try
            {
                if (!File.Exists(filePath))
                    return new T(); // 文件不存在时返回新实例

                var serializer = new XmlSerializer(typeof(T));
                using (var reader = new StreamReader(filePath))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                // 可选：记录日志
                // 反序列化失败时返回一个新实例，避免程序无法启动
                return new T();
            }
        }

        public static void Serialize<T>(T obj, string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            // 确保目录存在
            var directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }
    }

    // 你的配置类（新版本）
    [XmlRoot("Configuration")] // 指定XML根元素名称
    public class AppConfig
    {
        // 旧版本已存在的字段
        public string OldSetting { get; set; } = "DefaultValue";

        // 新增加的字段 StdX，设置默认值为 0
        public int StdX { get; set; } = 0; // [!code focus]

        // 对于值类型（如int, float, bool等），如果希望区分“未设置”和“显式设置为0”，
        // 或者旧配置中根本不存在该节点，可以考虑使用可空类型（Nullable<T>）。
        // 例如：
        // public int? StdX { get; set; } = null; // 默认认为不存在或未设置
        // 但在你的需求中，直接赋值为0即可，因为你需要为缺失项赋值为0。

        // 如果旧版本XML中不存在<StdX>节点，反序列化后StdX的值就是其默认值0。
        // 当新版本序列化此对象时，由于StdX值为0（或其他非默认值），它会被序列化到XML中。
    }
}
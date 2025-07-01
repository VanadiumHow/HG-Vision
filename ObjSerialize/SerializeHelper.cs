using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

/****************************************************************

*****************************************************************/
namespace Obj_Serialize
{ 
    public class SerializeHelper
    {

        //使用二进制序列化，必须为每一个要序列化的的类和其关联的类加上[Serializable] 特性，对类中不需要序列化的成员可以使用[NonSerialized] 特性。
        //二进制序列化对象时，能序列化类的所有成员(包括私有的)，且不需要类有无参数的构造方法。

        /// <summary>
        /// 二进制序列化器
        /// </summary>
        public static void BinarySerialize<T>(string fileName,T data)
        {
            using (Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
            {
                BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
                binFormat.Serialize(fStream, data);
            }          
        }

        /// <summary>
        /// 二进制反序列化器
        /// </summary>
        public static T BinaryDeserialize<T>(string fileName)
        {
            using (Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
            {
                BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
                //使用二进制反序列化对象
                fStream.Position = 0;//重置流位置
                return (T)binFormat.Deserialize(fStream);//反序列化对象
            }
        }


        //使用XML序列化或反序列化时，需要对XML序列化器指定需要序列化对象的类型和其关联的类型。
        //XML序列化只能序列化对象的公有属性，并且要求对象有一个无参的构造方法，否者无法反序列化。
        //[Serializable]和[NonSerialized] 特性对XML序列化无效！所以使用XML序列化时不需要对对象增加[Serializable] 特性。

        /// <summary>
        /// XML序列化器
        /// </summary>
        public static void XmlSerialize<T>(string fileName, List<T> dataList)
        {
            //使用XML序列化对象
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<T>));//创建XML序列化器，需要指定对象的类型 }
                xmlFormat.Serialize(fStream, dataList);
            }           
        }


        /// <summary>
        /// XML反序列化器
        /// </summary>
        public static List<T> XmlDeserialize<T>(string fileName)
        {
            //使用XML序列化对象
            using (Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<T>));//创建XML序列化器，需要指定对象的类型
                //使用XML反序列化对象
                fStream.Position = 0;//重置流位置
                List<T> pList = pList = (List<T>)xmlFormat.Deserialize(fStream);
                return pList;
            }
        }
    }
}

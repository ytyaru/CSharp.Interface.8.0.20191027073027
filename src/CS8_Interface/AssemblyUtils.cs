using System;
using System.Linq;
using System.Reflection;

namespace CS8_Interface
{
    /// <summary>
    /// Assembly クラスに関する汎用関数を管理するクラス。
    /// http://baba-s.hatenablog.com/entry/2014/06/10/200710
    /// </summary>
    public static class AssemblyUtils
    {
        /// <summary>
        /// 現在実行中のコードを格納しているアセンブリ内の指定されたインターフェイスが実装されているすべての Type を返します
        /// </summary>
        public static Type[] GetInterfaces<T>()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(c => c.GetInterfaces().Any(t => t == typeof(T))).ToArray();
        }
        
        /// <summary>
        /// 現在実行中のコードを格納しているアセンブリ内の指定されたインターフェイスが実装されているすべての Type のインスタンスを作成して返します
        /// </summary>
        public static T[] CreateInterfaceInstances<T>() where T : class
        {
            return GetInterfaces<T>().Select(c => Activator.CreateInstance(c) as T).ToArray();
        }
    }
}

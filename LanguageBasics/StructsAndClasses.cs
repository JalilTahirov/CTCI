using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics
{
    internal class StructsAndClasses
    {
    }


    public struct Mystruct : IMyinterface
    {
        public int MyProperty { get; set; }

        public int MyValue { get; set; }

        public string name;

        private string secretName;

        public string secretSecret()
        {
            secretName = name + "secret";
            return secretName;
        }

        public string SomeMethod()
        {
            throw new NotImplementedException();
        }
    }

    public class myclass
    { }

    public interface IMyinterface
    {
        string SomeMethod();
    }


}

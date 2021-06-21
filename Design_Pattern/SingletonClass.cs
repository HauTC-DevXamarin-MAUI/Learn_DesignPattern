using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Pattern
{//Singleton: muon sd 1 class. moi thu phai goi qua mot thuc the duy nhat (Instance)
    //khong  cho constructor public
    //muon sd class nay phai thong qua 1 thuc the . Instance
    class SingletonClass
    {
        //de k goi kieu SingletonClass single = new SingletonClass(); ben class khac
        private SingletonClass()
        { }
        //tao 1 bien Instance
        private static volatile SingletonClass instance; //volatile: tranh dung do Thread

        static object key = new object();
        internal static SingletonClass Instance
        {
            //giai quyet dong bo
            get 
            {
                if(instance==null)
                {
                    lock (key)
                    {
                        instance = new SingletonClass();
                    }
                }
                return instance; 
            }
            //set { SingletonClass.instance = value; } // Khong cho Set tu ben ngoai
        }

        public void Demo()
        {
            MessageBox.Show("Hau dep troai qua di a`");
        }
        public void PrintString(string s)
        {
            MessageBox.Show(s);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Buildder
{
    public class Pizza
    {
        private string size;
        private string sauseSelection;
        private List<string> toppings;
        private List<string> additions;
        private string crustType;


        public string Size { get { return size; } set { size = value; } }
        public List<string> Toppings { get { return toppings; } set { toppings = value; } }
        public List<string> Additions { get { return additions; } set { additions = value; } }
        public string CrustType { get { return crustType; } set {   crustType = value; } }
        public string SauseSelection { get { return sauseSelection; } set { sauseSelection = value; } }
        


    }
}

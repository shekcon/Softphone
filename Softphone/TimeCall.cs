using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softphone
{
    public enum ListIDCall{
        unknown,
        inComing,
        calling,
        missing
    };
    public class TimeCall
    {
        public string name { get; set; }
        public string number { get; set; }
        public string timeCall { get; set; }
        public ListIDCall idCall {get; set;}
        public string dateCall { get; set; }
        public string timeDateCall { get; set; }
        public string getData()
        {
            return  name + ":" +
                    number + "-" +
                    timeCall + "-" +
                    (idCall.ToString()) + ":" +
                    dateCall + ":" +
                    timeDateCall; 
        }
        public void translateData(string dataFile)
        {
            //todo
        }
    }
}

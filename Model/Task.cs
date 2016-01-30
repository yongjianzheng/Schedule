using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Task
    {
        
        private string _title;
        private string _detail;
        private string _begintime;
        private string _notifytime;
        private int _finished;
        private string _type;
        private string _priority;


        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }

        public string Detail
        {
            set { _detail = value; }
            get { return _detail; }
        }
        public string BeginTime
        {
            set { _begintime = value; }
            get { return _begintime; }
        }
        public string NotifyTime
        {
            set { _notifytime = value; }
            get { return _notifytime; }
        }
      
        public int Finished
        {
            set { _finished = value; }
            get { return _finished; }
        }
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        public string Priority
        {
            set { _priority = value; }
            get { return _priority; }
        }

  
    }
}

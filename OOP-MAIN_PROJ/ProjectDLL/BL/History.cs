using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.BL
{
    internal class History
    {
        private string studentName;
        private string bookName;
        private DateTime issueDate;
        private DateTime returnDate;

        public History(string studentName, string bookName, DateTime issueDate, DateTime returnDate)
        {
            this.studentName = studentName;
            this.bookName = bookName;
            this.issueDate = issueDate;
            this.returnDate = returnDate;
        }
        public History() { }

    }
}

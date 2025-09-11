using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TASK
{
    internal class ClassDiagram
    {


        //1. Student Class
        //Attributes:
        //ID: int (Primary Key)
        //FName: string
        //LName: string
        //Address: string
        //Age: int
        //Dep_ID: int (Foreign Key)

        //2. Course Class
        //Attributes:
        //ID: int (Primary Key)
        //Duration: int
        //Name: string
        //Description: string
        //Top_ID: int (Foreign Key)

        //3. Department Class
        //Attributes:       
        //ID: int (Primary Key)       
        //Name: string      
        //Ins_ID: int (Foreign Key)       
        //HiringDate: date

        //4. Instructor Class
        //Attributes:
        //ID: int (Primary Key)
        //Name: string
        //Bouns: double
        //Salary: double
        //Adrees: string
        //HourRate: double
        //Dept_ID: int (Foreign Key)

        //5. Topic Class
        //Attributes:
        //ID: int (Primary Key)
        //Name: string
    }
}
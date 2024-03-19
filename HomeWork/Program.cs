class CTU_Array
{
    static void Main(string[] args)
    {   //declare array       
        string[,] student_infos = { 
            //[0,0] student 1|[0,1]Name | [0,2]Gender| [0,3]D.O.B
            {"1","Victor Masakada", "M","07.05.1990\n"}, 
            //[1,0] student 2|[1,1]Name | [1,2]Gender| [1,3]D.O.B
            {"2","Lusukama Selemani", "M","07.01.1982\n"},
            //[2,0] student 3|[2,1]Name | [2,2]Gender| [2,3]D.O.B
            {"3","Nonhlanhla Empangeni", "F","07.05.1992\n"}
        };

        //loop through columns
        for (int i = 0; i < student_infos.GetLength(0); i++)
        {
            //loop through rows
            for (int j = 0; j < student_infos.GetLength(1); j++)
            {
                //assign row number to type of information (name/gender/d.o.b) and print
                if (j == 0)
                {
                    Console.WriteLine("Student: " +student_infos[i, j]);
                }
                else if (j == 1)
                {
                    Console.WriteLine("Name: " + student_infos[i, j]);
                }
                else if (j == 2)
                {
                    Console.WriteLine("Gender: " + student_infos[i, j]);
                }
                else if (j == 3)
                {
                    Console.WriteLine("D.O.B: " + student_infos[i, j]);
                } else
                {
                    //if there are more rows than there should be and error would be thrown at the user.
                    Console.WriteLine("ERROR: OUT OF BOUNDS");
                }

            }
        }
    }
}
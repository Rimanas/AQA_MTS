
    public class DocMethods
    {
        public string numberDoc;
    public void PrintDocument()
        {
            Console.WriteLine($" Number of Document: {numberDoc}");
        }

    public void PrintNumberDoc()
    {
        string numberDocA= numberDoc.Substring(0,numberDoc.Length-9);
        //Обрезаем все , что после 5 индекса
        string numberDoc1 = numberDocA.Substring(5);
        string numberDoc2 = numberDocA.Substring(8);
        //numberDoc1 += numberDoc2;
        Console.WriteLine($" Two blocks of Numbers: {numberDoc2}");
    }


}

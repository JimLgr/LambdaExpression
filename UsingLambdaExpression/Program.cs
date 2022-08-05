delegate int DlgArithmethique(int pLeft, int pRight);
delegate int DlgCarre(int pNombre);



public class Program
{
    public static void Main(string[] args)
    {
        //code
        Func<int, int> myCarreFunc;


        //code
        DlgArithmethique myDlg;
        //code
        myDlg = new DlgArithmethique(Addition);
        //code
        //appel au délégué
        int result = myDlg(6, 3);
        Console.WriteLine($"L'addition de 6 + 3 = {result}");


        myDlg = delegate (int pNombreUn, int pNombreDeux)
        {
            return pNombreUn - pNombreDeux;
        };

        //code
        //appel au délégué
        result = myDlg(6, 3);
        Console.WriteLine($"La soustraction de 6-3 = {result}");
        //Lambda Expression
        myDlg = (pNombreUn, pNombreDeux) => pNombreUn * pNombreDeux;


        result = myDlg(6, 3);
        Console.WriteLine($"La Multiplication de 6-3 = {result}");

        myDlg = (int pNombreUn, int pNombreDeux) =>
        {
            return pNombreUn / pNombreDeux;
        };
        result = myDlg(6, 3);
        Console.WriteLine($"La Division de 6-3 = {result}");


        DlgCarre myCarre;
        myCarre = val => val * val;
        result = myCarre(6);
        Console.WriteLine($"Le carré de 6 = {result}");


    }
    private static int Addition(int valueUn, int ValueDeux)
    {
        return valueUn + ValueDeux;
    }
}
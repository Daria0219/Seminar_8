// Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArr (int[,] array)
{   for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            array[i,j] = new Random().Next(0,10);}
}   }
void PrintArr(int[,] array)
{   for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++)
        {Console.Write(array[i,j]+" ");}
Console.WriteLine();}}

Console.WriteLine("Введите число строк");
int str = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int stolb = int.Parse(Console.ReadLine());

int [,] mass = new int[str,stolb];
FillArr(mass);
PrintArr(mass);

void Function (int[,] array){
int temp=0;
int max=0;
int NumMaxi=0;
int NumMaxj=0;
for (int i=0; i<array.GetLength(0); i++){
    for (int n=0; n<array.GetLength(1); n++){
        for (int j=n; j<array.GetLength(1); j++){
            if (array[i,j]>max) {
                max=array[i,j];
                NumMaxi=i;
                NumMaxj=j;}}
        if (n!=(array.GetLength(1)-1)){
        temp=array[i,n];
        array[i,n]=max;
        array[NumMaxi,NumMaxj]=temp;}
        max=0;}
} }
Function(mass);
Console.WriteLine();
PrintArr(mass);
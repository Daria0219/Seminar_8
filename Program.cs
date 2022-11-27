/* Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
*/

/* программа, которая находит строку с наименьшей суммой элементов

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

void MinSumElStr (int[,] array){
int MinSum=1000000;
int SumEl=0;
int NumStr=0;
for (int i=0; i<array.GetLength(0); i++){
    for (int j=0; j<array.GetLength(1); j++)
        SumEl=array[i,j]+SumEl;
    if (SumEl<MinSum) {
        MinSum=SumEl;
        NumStr=i;}
    SumEl=0;
}
Console.WriteLine($"строка с наименьшей суммой элементов - {NumStr+1}");
}
MinSumElStr(mass);
*/
/* произведение двух матриц

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

Console.WriteLine("Введите число строк и столбцов первой матрицы");
int str1 = int.Parse(Console.ReadLine());
int stolb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число строк и столбцов второй матрицы (количество столбцов первой матрицы должно быть равно количеству строк второй матрицы)");
int str2 = int.Parse(Console.ReadLine());
int stolb2 = int.Parse(Console.ReadLine());

if (stolb1!=str2) Console.WriteLine("Ошибка, количество столбцов первой матрицы не равно количеству строк второй матрицы");
return;

int [,] mass1 = new int[str1,stolb1];
int [,] mass2 = new int[str2,stolb2];
FillArr(mass1);
FillArr(mass2);
PrintArr(mass1);
Console.WriteLine();
PrintArr(mass2);
Console.WriteLine();
int [,] UmnozenieMatriz(int[,] array1, int[,] array2){
    int[,] newArray = new int [array1.GetLength(0),array2.GetLength(1)];
        for (int i=0; i<array1.GetLength(0); i++){
            for (int l=0; l<array2.GetLength(1); l++){
                int k=0;
                for (int j=0; j<array1.GetLength(1); j++){
                    newArray[i,l]=newArray[i,l]+array1[i,j]*array2[k,l];
                    k++;}        
        }
}   return newArray;
}
int [,] mass3=UmnozenieMatriz(mass1, mass2);
PrintArr(mass3);
*/

// трёхмерный массив из неповторяющихся двузначных чисел
//программа, которая построчно выводит трёхмерный массив, добавляя индексы каждого элемента

void FillArr (int[,,] array)
{  for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            for (int k=0; k<array.GetLength(1); k++){
                array[i,j,k] = new Random().Next(10,100);}}}
     
for (int i=0; i<array.GetLength(0); i++){
    for (int j=0; j<array.GetLength(1); j++){
        for (int k=0; k<array.GetLength(2); k++){
            for (int x=0; x<array.GetLength(0); x++){
                for (int y=0; y<array.GetLength(1); y++){
                    for (int z=0; z<array.GetLength(2); z++){
                        if (i!=x || j!=y || k!=z){
                            while (array[i,j,k] == array [x,y,z]) array[i,j,k] = new Random().Next(10,100);
                        }}}}}}}}

void PrintArr(int[,,] array)
{   for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
        Console.WriteLine();
            for (int k=0; k<array.GetLength(1); k++)
        {Console.Write($"{array[i,j,k]}({i},{j},{k}) ");}
}}}

int [,,] mass = new int[2,2,2];
FillArr(mass);
PrintArr(mass);


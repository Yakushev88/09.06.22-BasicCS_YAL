// Рекурсии

// 69. Найти сумму элементов от M до N, N и M заданы

int P(int M, int N)
{
    if (M==N) return M;
    else return P(M+1,N)+ M;
}
System.Console.WriteLine(P(1,8));
// Подстановкой выполняем
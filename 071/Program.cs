// 71. Написать программу вычисления функции Аккермана

static UInt32 S(uint n, uint m)
{
  if (n == 0)
    return n + 1;
  else
    if ((n != 0) && (m == 0))
      return S(n - 1, m);
    else
      return S(n -1, S(n, m -1));
}
System.Console.WriteLine(S(4,5));
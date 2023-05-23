// DLL.cpp : Определяет экспортируемые функции для DLL.
//
#define _CRT_SECURE_NO_WARNINGS
#include "framework.h"
#include "DLL.h"
#include <string>


// Пример экспортированной переменной
DLL_API int nDLL=0;

// Пример экспортированной функции.
DLL_API int fnDLL(void)
{
    return 0;
}

// Конструктор для экспортированного класса.
CDLL::CDLL()
{
    return;
}

DLL_API void TestFunc(wchar_t* Text, size_t Size)
{
    for (int i = 0; i < Size; ++i)
    {
        if (i % 2) Text[i] = '-';
    }
}

DLL_API void TestFunc2(wchar_t* str1, const wchar_t* str2, size_t str1leng)
{
    wcsncat(str1, str2, str1leng);
}

DLL_API const wchar_t* TestFunc3(wchar_t* str1, wchar_t* str2)
{
    const size_t n = 50;
    const wchar_t* result = new wchar_t[n];
    std::wstring s(str1);
    s += std::wstring(str2);
    result = s.c_str();
    return result;
}

DLL_API void deleteString(const wchar_t* s)
{
    delete[] s;
}

DLL_API void SaveExpression(char** s)
{
    std::ofstream WriteFile("Expression.txt");
    WriteFile.clear();
    WriteFile << *s;
    WriteFile.close();
}

DLL_API void Calculate()
{
    std::ifstream ReadFile("Expression.txt");
    std::string Expr;
    getline(ReadFile, Expr);
    ReadFile.close();
    std::string deleteWhiteSpace = " ";
    size_t Index{ Expr.find(deleteWhiteSpace) };
    while (Index != std::string::npos)
    {
        Expr.erase(Index, deleteWhiteSpace.length());
        Index = Expr.find(deleteWhiteSpace, Index + deleteWhiteSpace.length());
    }
    std::ofstream WriteFile("Solution.txt");
    WriteFile << Expr << "\n";
    WriteFile.close();
}

DLL_API void ShowSolution(char** s)
{
    std::ifstream ReadFile("Solution.txt");
    if (!ReadFile.is_open())
        return;

    std::string c(
        (std::istreambuf_iterator<char>(ReadFile)),
        std::istreambuf_iterator<char>()
    );

    *s = (char*)CoTaskMemAlloc(c.length());
    strcpy(*s, c.c_str());
}
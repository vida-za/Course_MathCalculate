// DLL.cpp : Определяет экспортируемые функции для DLL.
//
#define _CRT_SECURE_NO_WARNINGS
#include <combaseapi.h>
#include "framework.h"
#include "DLL.h"
#include "DB.h"
#include <string>

void ReturnResult(char* s1, char** s2)
{
    DB database;
    database.Push(std::string(s1));
    std::string res = (database.GetLastElement()).StringResult();
    *s2 = (char*)CoTaskMemAlloc(res.length() + 1);
    strcpy_s(*s2, res.length() + 1, res.c_str());
}

void ReturnPostfixForm(char* s1, char** s2)
{
    DB database;
    database.Push(std::string(s1));
    std::string res = (database.GetLastElement()).StringPostfixExpr();
    *s2 = (char*)CoTaskMemAlloc(res.length() + 1);
    strcpy_s(*s2, res.length() + 1, res.c_str());
}
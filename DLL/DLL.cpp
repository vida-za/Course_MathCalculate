// DLL.cpp : Определяет экспортируемые функции для DLL.
//
#define _CRT_SECURE_NO_WARNINGS
#include <combaseapi.h>
#include "framework.h"
#include "DLL.h"
#include "DB.h"
#include <string>
#include <fstream>

DB database;

void ReturnResult(char** s)
{
    std::string res = (database.GetLastCreateElement()).GetStringResult();
    *s = (char*)CoTaskMemAlloc(res.length() + 1);
    strcpy_s(*s, res.length() + 1, res.c_str());
}

void ReturnPostfixForm(char** s)
{
    std::string res = (database.GetLastCreateElement()).GetStringPostfixExpr();
    *s = (char*)CoTaskMemAlloc(res.length() + 1);
    strcpy_s(*s, res.length() + 1, res.c_str());
}

void SaveExpression(char* s)
{
    database.Push(std::string(s));
}

void SizeHistory(int& c)
{
    c = database.GetSizeDB();
}

void ReadMyFileSolution(char** Ex, char** Pf, char** Res, int& ID)
{
    std::string currentRow;
    std::string ex = "", pf = "", res = "";
    std::string nameFile = "Solution" + std::to_string(ID);
    try
    {
        /*std::ifstream file(nameFile);
        while (getline(file, currentRow))
        {
            if (currentRow.find("Expression") != std::string::npos)
                for (int i = currentRow.find(": ") + 2; i < currentRow.size(); i++)
                    ex += currentRow[i];
            else if (currentRow.find("postFix") != std::string::npos)
                for (int i = currentRow.find(": ") + 2; i < currentRow.size(); i++)
                    pf += currentRow[i];
            else if (currentRow.find("Result") != std::string::npos)
                for (int i = currentRow.find(": ") + 2; i < currentRow.size(); i++)
                    res += currentRow[i];
        }*/
        LoadData(nameFile, ex, pf, res);
        *Ex = (char*)CoTaskMemAlloc(ex.length() + 1);
        *Pf = (char*)CoTaskMemAlloc(pf.length() + 1);
        *Res = (char*)CoTaskMemAlloc(res.length() + 1);
        strcpy_s(*Ex, ex.length() + 1, ex.c_str());
        strcpy_s(*Pf, pf.length() + 1, pf.c_str());
        strcpy_s(*Res, res.length() + 1, res.c_str());
    }
    catch (const std::exception &exc)
    {
        std::cerr << exc.what();
    }
}

void InitDB()
{
    database.Init();
}

int* CalcEqual(char* s, int& len)
{
    int* arr = database.SearchEquals(s, len);
    return arr;
}

void ClearEqual(int* arr)
{
    delete[] arr;
}
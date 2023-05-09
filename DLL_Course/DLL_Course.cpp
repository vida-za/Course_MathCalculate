// DLL_Course.cpp : Определяет экспортируемые функции для DLL.
//

#include "framework.h"
#include "DLL_Course.h"


// Пример экспортированной переменной
DLLCOURSE_API int nDLLCourse=0;

// Пример экспортированной функции.
DLLCOURSE_API int fnDLLCourse(void)
{
    return 0;
}

// Конструктор для экспортированного класса.
CDLLCourse::CDLLCourse()
{
    return;
}

DLLCOURSE_API int x()
{
    return 10;
}

DLLCOURSE_API float y()
{
    return 5.8;
}
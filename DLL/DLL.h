// Приведенный ниже блок ifdef — это стандартный метод создания макросов, упрощающий процедуру
// экспорта из библиотек DLL. Все файлы данной DLL скомпилированы с использованием символа DLL_EXPORTS
// Символ, определенный в командной строке. Этот символ не должен быть определен в каком-либо проекте,
// использующем данную DLL. Благодаря этому любой другой проект, исходные файлы которого включают данный файл, видит
// функции DLL_API как импортированные из DLL, тогда как данная DLL видит символы,
// определяемые данным макросом, как экспортированные.
#ifdef DLL_EXPORTS
#define DLL_API __declspec(dllexport)
#else
#define DLL_API __declspec(dllimport)
#endif

//DB database;

extern "C"
{
	DLL_API void ReturnResult(char** s);
	DLL_API void ReturnPostfixForm(char** s);
	DLL_API void SaveExpression(char* s);
	DLL_API void SizeHistory(int& c);
	DLL_API void ReadMyFileSolution(char** Ex, char** Pf, char** Res, int& ID);
	DLL_API void InitDB();
	DLL_API int* CalcEqual(char* s, int& len);
	DLL_API void ClearEqual(int* arr);
}
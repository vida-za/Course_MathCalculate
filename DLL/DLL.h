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

// Этот класс экспортирован из библиотеки DLL
class DLL_API CDLL {
public:
	CDLL(void);
	// TODO: добавьте сюда свои методы.
};

extern DLL_API int nDLL;

DLL_API int fnDLL(void);

extern "C"
{
	DLL_API void TestFunc(wchar_t* Text, size_t Size);
	DLL_API void TestFunc2(wchar_t* str1, const wchar_t* str2, size_t str1leng);
	DLL_API const wchar_t* TestFunc3(wchar_t* str1, wchar_t* str2);
	DLL_API void deleteString(const wchar_t* s);
}
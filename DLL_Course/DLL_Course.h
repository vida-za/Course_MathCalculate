// Приведенный ниже блок ifdef — это стандартный метод создания макросов, упрощающий процедуру
// экспорта из библиотек DLL. Все файлы данной DLL скомпилированы с использованием символа DLLCOURSE_EXPORTS
// Символ, определенный в командной строке. Этот символ не должен быть определен в каком-либо проекте,
// использующем данную DLL. Благодаря этому любой другой проект, исходные файлы которого включают данный файл, видит
// функции DLLCOURSE_API как импортированные из DLL, тогда как данная DLL видит символы,
// определяемые данным макросом, как экспортированные.
#ifdef DLLCOURSE_EXPORTS
#define DLLCOURSE_API __declspec(dllexport)
#else
#define DLLCOURSE_API __declspec(dllimport)
#endif

// Этот класс экспортирован из библиотеки DLL
class DLLCOURSE_API CDLLCourse {
public:
	CDLLCourse(void);
	// TODO: добавьте сюда свои методы.
};

extern DLLCOURSE_API int nDLLCourse;

DLLCOURSE_API int fnDLLCourse(void);

extern "C"
{
	DLLCOURSE_API int x();
	DLLCOURSE_API float y();
}
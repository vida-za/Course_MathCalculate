#pragma once
#include <string>
#include <vector>

template <typename T>
void DeleteFirstElement(std::vector<T> &v);

template <typename T>
void DeleteLastElement(std::vector<T> &v);

template <typename T>
T ViewLastElement(std::vector<T> &v);

int Priority(char op);

class Math
{
	friend struct Pred;
	friend class DB;
private:
	std::string sExpression;
	std::vector<char> vExpression;
	std::vector<char> vPostfixExpr;
	std::string sResult;
	double dResult;
public:
	Math();
	Math(std::string expr);
	~Math();

	std::string StringResult();
};

template<typename T>
inline void DeleteFirstElement(std::vector<T>& v)
{
	typename std::vector<T>::iterator Del = v.begin();
	v.erase(Del);
}

template<typename T>
inline void DeleteLastElement(std::vector<T>& v)
{
	typename std::vector<T>::iterator Del = v.end();
	std::advance(Del, -1);
	v.erase(Del);
}

template<typename T>
inline T ViewLastElement(std::vector<T>& v)
{
	typename std::vector<T>::iterator it = v.end();
	std::advance(it, -1);
	return *it;
}
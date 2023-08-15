#pragma once
#include <string>
#include <vector>
#include <fstream>
#include <iostream>

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
	static int count;
	int ID;
	std::string nameFile;
	std::string sExpression;
	std::string sPostfixExpr;
	std::string sResult;
	std::vector<char> vExpression;
	std::vector<char> vPostfixExpr;
	double dResult;
public:
	Math();
	Math(std::string expr);
	Math(const Math& obj_for_copy);
	~Math();

	Math* Copy();
	void SaveData();
	std::string StringPostfixExpr();
	std::string StringResult();
	void UpdateCount();
	int GetCount();
	Math& operator = (const Math& obj_for_copy);
	bool operator < (const Math& Next) const;
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
#pragma once
//#include "DB.h"
#include <sstream>
#include <string>
#include <vector>
#include <fstream>
#include <map>
#include <iostream>

void LoadData(std::string name, std::string& Expr, std::string& Pstf, std::string& Res);

double StringToDouble(const std::string& s);

int getEditDistance(std::string first, std::string second);

double findStringSimilarity(std::string first, std::string second);

template <typename T>
void DeleteFirstElement(std::vector<T> &v);

template <typename T>
void DeleteLastElement(std::vector<T> &v);

template <typename T>
T ViewLastElement(std::vector<T> &v);

int Priority(char op);

class Math
{
	friend struct PredID;
	friend class DB;
private:
	static int count;
	int ID;
	std::string nameFile;
	std::string sPostfixExpr;
	std::string sResult;
	std::vector<char> vExpression;
	std::vector<char> vPostfixExpr;
	double dResult;

	std::string lastSearch;
	std::map<std::string, double> similarity;
public:
	Math();
	Math(int id);
	Math(std::string expr);
	Math(const Math& obj_for_copy);
	~Math();

	std::string sExpression;

	Math* Copy();
	void CheckMap(std::string search);
	void SaveData();
	std::string GetStringExpression();
	std::string GetStringPostfixExpr();
	std::string GetStringResult();
	void UpdateCount();
	int GetCount();
	int GetID();
	Math& operator = (const Math& obj_for_copy);
	bool operator < (const Math& Next) const;
	bool operator << (const Math& Next) const;
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
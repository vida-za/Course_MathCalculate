#pragma once
#include "Math.h"
#include <set>
#include <fstream>
#include <algorithm>
#include <iostream>

struct PredID {
	bool operator()(const Math& First, const Math& Second) const {
		return First < Second;
	}
};

struct PredExpr {
	bool operator()(const Math& First, const Math& Second) const {
		return First << Second;
	}
};

struct Comp {
	bool operator()(const Math& o, std::string s) const {
		return findStringSimilarity(o.sExpression, s) == 0;
	}
	bool operator()(std::string s, const Math& o) const {
		return findStringSimilarity(s, o.sExpression) > 1;
	}
};

class DB
{
private:
	std::multiset<Math, PredID> db;
	std::multiset<Math>::iterator lastCreateElement;
public:
	DB();
	DB(const DB& obj_for_copy);
	~DB();

	void Init();
	void Push(std::string expr);
	void CreateSimilarity(std::string search);
	DB* Copy();
	int GetSizeDB();
	Math GetLastCreateElement();
	int* SearchEquals(std::string searchExpr, int& size);

};
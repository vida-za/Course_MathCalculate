#pragma once
#include "Math.h"
#include <set>
#include <fstream>
#include <algorithm>
#include <iostream>

struct Pred {
	bool operator()(const Math& First, const Math& Second) const {
		return First < Second;
	}
};

class DB
{
	std::set<Math, Pred> db;
	std::set<Math>::iterator lastCreateElement;
public:
	DB();
	DB(const DB& obj_for_copy);
	~DB();

	void Init();
	DB* Copy();
	int GetSizeDB();
	Math GetLastCreateElement();
	void Push(std::string expr);
};
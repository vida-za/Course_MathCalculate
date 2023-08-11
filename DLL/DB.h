#pragma once
#include "Math.h"
#include <set>
#include <algorithm>
#include <iostream>

struct Pred {
	bool operator()(const Math& First, const Math& Second) const {
		return First.dResult < Second.dResult;
	}
};

class DB
{
	std::set<Math, Pred> db;
public:
	DB();
	~DB();

	Math GetLastElement();
	void Push(std::string expr);
};
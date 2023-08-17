#include "DB.h"

DB::DB()
{

}

DB::DB(const DB& obj_for_copy)
{
	db = obj_for_copy.db;
	lastCreateElement = obj_for_copy.lastCreateElement;
}

DB::~DB()
{
}

void DB::Init()
{
	Math temp;
	temp.UpdateCount();
	for (int i = 0; i < temp.count; ++i)
	{
		db.insert(Math(i + 1));
	}
}

DB* DB::Copy()
{
	return new DB(*this);
}

int DB::GetSizeDB()
{
	Math temp;
	std::multiset<Math, PredID>::iterator it = db.end();
	if (!db.empty())
	{
		it--;
		return (*it).count;
	}
	else return temp.GetCount();
}

Math DB::GetLastCreateElement()
{
	if (lastCreateElement == db.end()) return Math();
	return *lastCreateElement;
	/*for (std::set<Math, Pred>::iterator it = db.begin(); it != db.end(); it++)
	{
		if (lastCreateElement == it) return *lastCreateElement;
	}*/
}

void DB::Push(std::string expr)
{
	std::multiset<Math> NewElement;
	//std::set<Math, Pred> dbCopyBehind;
	DB* dbCopy = Copy();
	if (!db.empty())
	{
		db.insert(Math(expr));
		try
		{
			std::set_difference(db.begin(), db.end(), dbCopy->db.begin(), dbCopy->db.end(), std::inserter(NewElement, NewElement.end()));
			if (!NewElement.empty())
			{
				lastCreateElement = NewElement.begin();
				for (std::multiset<Math>::iterator it = db.begin(); it != db.end(); ++it)
					if ((*it).sExpression == (*lastCreateElement).sExpression)
						lastCreateElement = it;
			}
		}
		catch (...)
		{
			lastCreateElement = db.begin();
		}
	}
	else
	{
		db.insert(Math(expr));
		lastCreateElement = db.begin();
	}
	//lastCreateElement = std::set_difference(dbCopyBehind.begin(), dbCopyBehind.end(), db.begin(), db.end(), NewElement.begin());
}

int* DB::SearchEquals(std::string searchExpr, int& size)
{
	CreateSimilarity(searchExpr);
	std::multiset <Math, PredExpr> temp;
	std::copy(db.begin(), db.end(), std::inserter(temp, temp.begin()));
	const auto equal = std::equal_range(temp.begin(), temp.end(), searchExpr, Comp());
	std::vector<int> vArr;
	for (auto j = equal.first; j != equal.second; ++j)
	{
		vArr.push_back((*j).ID);
	}
	size = vArr.size();
	if (!vArr.empty())
	{
		int* iArr = new int[vArr.size()];
		for (int i = vArr.size() - 1; i >= 0; --i)
		{
			iArr[vArr.size() - i - 1] = vArr[i];
		}
		return iArr;
	}
	else return nullptr;
}

void DB::CreateSimilarity(std::string search)
{
	for (std::multiset<Math>::iterator it = db.begin(); it != db.end(); ++it)
	{
		(const_cast<Math&>(*it)).CheckMap(search);
	}
}
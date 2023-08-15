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
}

DB* DB::Copy()
{
	return new DB(*this);
}

int DB::GetSizeDB()
{
	Math temp;
	std::set<Math, Pred>::iterator it = db.end();
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
	std::set<Math> NewElement;
	//std::set<Math, Pred> dbCopyBehind;
	DB* dbCopy = Copy();
	if (!db.empty())
	{
		db.insert(Math(expr));
		try
		{
			std::set_difference(dbCopy->db.begin(), dbCopy->db.end(), db.begin(), db.end(), std::inserter(NewElement, NewElement.end()));
			if (!NewElement.empty()) lastCreateElement = NewElement.begin();
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
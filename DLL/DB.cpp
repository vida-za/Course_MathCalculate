#include "DB.h"

DB::DB()
{
}

DB::~DB()
{
}

Math DB::GetLastElement()
{
	std::set<Math>::iterator it = db.end();
	std::advance(it, -1);
	return *it;
}

void DB::Push(std::string expr)
{
	db.insert(Math(expr));
}
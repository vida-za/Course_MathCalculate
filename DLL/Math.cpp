#include "Math.h"

int Math::count = 0;

Math::Math()
{
    if (count == 0) count++;
    ID = count;
	sExpression = "";
    sPostfixExpr = "";
	sResult = "";
	dResult = 0.0;
}

Math::Math(std::string expr)
{
    count++;
    ID = count;

	sExpression = expr;

	for (int i = 0; i < sExpression.length(); i++)
		vExpression.push_back(sExpression[i]);

	std::vector<char> cTemp;
    while (!vExpression.empty())
    {
        char CurrentCharExpression = '?';
        char CurrentCharTemp = '?';
        CurrentCharExpression = vExpression[0];
        if (!cTemp.empty()) CurrentCharTemp = ViewLastElement(cTemp);
        if (isdigit(CurrentCharExpression))
        {
            vPostfixExpr.push_back(CurrentCharExpression);
            DeleteFirstElement(vExpression);
        }
        else if (CurrentCharExpression == '(')
        {
            cTemp.push_back(CurrentCharExpression);
            DeleteFirstElement(vExpression);
        }
        else if (CurrentCharExpression == ')')
        {
            while (cTemp.size() > 0 && CurrentCharTemp != '(')
            {
                vPostfixExpr.push_back(CurrentCharTemp);
                DeleteLastElement(cTemp);
                if (!cTemp.empty()) CurrentCharTemp = ViewLastElement(cTemp);
            }
            DeleteLastElement(cTemp);
            DeleteFirstElement(vExpression);
        }
        else if (Priority(CurrentCharExpression) != -1)
        {
            while (cTemp.size() > 0 && Priority(CurrentCharTemp) >= Priority(CurrentCharExpression))
            {
                vPostfixExpr.push_back(CurrentCharTemp);
                DeleteLastElement(cTemp);
                if (!cTemp.empty()) CurrentCharTemp = ViewLastElement(cTemp);
            }
            cTemp.push_back(CurrentCharExpression);
            DeleteFirstElement(vExpression);
        }
    }
    while (!cTemp.empty())
    {
        vPostfixExpr.push_back(ViewLastElement(cTemp));
        DeleteLastElement(cTemp);
    }

    std::vector<double> dTemp;
    for (int i = 0; i < vPostfixExpr.size(); i++)
    {
        sPostfixExpr += vPostfixExpr[i];
        double tmp = 0;
        if (isdigit(vPostfixExpr[i]))
        {
            dTemp.push_back(vPostfixExpr[i] - '0');
        }
        else
        {
            switch (vPostfixExpr[i])
            {
            case '+': tmp = dTemp[dTemp.size() - 2] + dTemp[dTemp.size() - 1]; break;
            case '-': tmp = dTemp[dTemp.size() - 2] - dTemp[dTemp.size() - 1]; break;
            case '*': tmp = dTemp[dTemp.size() - 2] * dTemp[dTemp.size() - 1]; break;
            case '/': tmp = dTemp[dTemp.size() - 2] / dTemp[dTemp.size() - 1]; break;
            case '^': tmp = pow(dTemp[dTemp.size() - 2], dTemp[dTemp.size() - 1]); break;
            default: break;
            }
            DeleteLastElement(dTemp);
            DeleteLastElement(dTemp);
            dTemp.push_back(tmp);
        }
    }
    if (!dTemp.empty())
    {
        dResult = dTemp[0];
        sResult = std::to_string(dResult);
    }
    else
    {
        dResult = 0.0;
        sResult = "Null";
    }
    dTemp.clear();
    SaveData();
}

Math::~Math()
{
}

void Math::SaveData()
{
    nameFile = "Solution" + std::to_string(ID);
    std::fstream file(nameFile);
    while (file.is_open())
    {
        count++;
        ID = count;
        file.close();
        nameFile = "Solution" + std::to_string(ID);
        file.open(nameFile);
    }
    std::ofstream outfile(nameFile);
    outfile << "Expression: " << sExpression << std::endl;
    outfile << "postFix form: " << sPostfixExpr << std::endl;
    outfile << "Result: " << sResult << std::endl;
    outfile.close();
}

std::string Math::StringPostfixExpr()
{
    if (vPostfixExpr.empty()) return "Null";
    else
    {
        std::string sPostfix = "";
        for (int i = 0; i < vPostfixExpr.size(); i++)
            sPostfix += vPostfixExpr[i];
        return sPostfix;
    }
}

Math::Math(const Math& obj_for_copy)
{
    count = obj_for_copy.count;
    ID = obj_for_copy.ID;
    nameFile = obj_for_copy.nameFile;
    sExpression = obj_for_copy.sExpression;
    sPostfixExpr = obj_for_copy.sPostfixExpr;
    sResult = obj_for_copy.sResult;
    dResult = obj_for_copy.dResult;
    for (std::vector<char>::const_iterator it = (obj_for_copy.vExpression).begin(); it != (obj_for_copy.vExpression).end(); it++)
    {
        vExpression.push_back(*it);
    }
    for (std::vector<char>::const_iterator it = (obj_for_copy.vPostfixExpr).begin(); it != (obj_for_copy.vPostfixExpr).end(); it++)
    {
        vPostfixExpr.push_back(*it);
    }
}

std::string Math::StringResult()
{
    return sResult;
}

Math* Math::Copy()
{
    return new Math(*this);
}

int Math::GetCount()
{
    return count;
}

void Math::UpdateCount()
{
    std::string File = "Solution" + std::to_string(ID);
    std::fstream file(File);
    while (file.is_open())
    {
        count++;
        ID = count;
        file.close();
        File = "Solution" + std::to_string(ID);
        try
        {
            file.open(File);
        }
        catch (...)
        {
            std::cerr << "File not found.";
        }
    }
    count--;
    ID = count;
}

Math& Math::operator=(const Math& obj_for_copy)
{
    vExpression.clear();
    vPostfixExpr.clear();

    count = obj_for_copy.count;
    ID = obj_for_copy.ID;
    nameFile = obj_for_copy.nameFile;
    sExpression = obj_for_copy.sExpression;
    sPostfixExpr = obj_for_copy.sPostfixExpr;
    sResult = obj_for_copy.sResult;
    dResult = obj_for_copy.dResult;
    for (std::vector<char>::const_iterator it = (obj_for_copy.vExpression).begin(); it != (obj_for_copy.vExpression).end(); it++)
    {
        vExpression.push_back(*it);
    }
    for (std::vector<char>::const_iterator it = (obj_for_copy.vPostfixExpr).begin(); it != (obj_for_copy.vPostfixExpr).end(); it++)
    {
        vPostfixExpr.push_back(*it);
    }

    return *this;
}
bool Math::operator<(const Math& Next) const
{
    return ID < Next.ID;
}

int Priority(char op)
{
    int p;
    switch (op)
    {
    case '(': p = 0; break;
    case '+': p = 1; break;
    case '-': p = 1; break;
    case '*': p = 2; break;
    case '/': p = 2; break;
    case '^': p = 3; break;
    default: p = -1; break;
    }
    return p;
}
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

Math::Math(int id)
{
    ID = id;
    nameFile = "Solution" + std::to_string(ID);
    LoadData(nameFile, sExpression, sPostfixExpr, sResult);
    dResult = StringToDouble(sResult);
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

std::string Math::GetStringExpression()
{
    return sExpression;
}

std::string Math::GetStringPostfixExpr()
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

    lastSearch = obj_for_copy.lastSearch;
    for (std::map<std::string, double>::const_iterator it = (obj_for_copy.similarity).begin(); it != (obj_for_copy.similarity).end(); ++it)
        similarity[it->first] = it->second;

    for (std::vector<char>::const_iterator it = (obj_for_copy.vExpression).begin(); it != (obj_for_copy.vExpression).end(); ++it)
        vExpression.push_back(*it);
    for (std::vector<char>::const_iterator it = (obj_for_copy.vPostfixExpr).begin(); it != (obj_for_copy.vPostfixExpr).end(); ++it)
        vPostfixExpr.push_back(*it);
}

std::string Math::GetStringResult()
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

int Math::GetID()
{
    return ID;
}

bool Math::operator< (const Math& Next) const
{
    return ID < Next.ID;
}

bool Math::operator<< (const Math& Next) const
{
    std::map<std::string, double>::const_iterator mapIt = similarity.find(lastSearch), nextMapIt = Next.similarity.find(Next.lastSearch);
    if (mapIt != similarity.end() && nextMapIt != Next.similarity.end()) return mapIt->second < nextMapIt->second;
    else return false;
    //return sExpression < Next.sExpression;
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

double StringToDouble(const std::string& s)
{
    std::istringstream i(s);
    double x;
    if (!(i >> x))
        return 0;
    return x;
}


void LoadData(std::string name, std::string& Expr, std::string& Pstf, std::string& Res)
{
    std::string currentRow;
    std::ifstream file(name);
    while (getline(file, currentRow))
    {
        if (currentRow.find("Expression") != std::string::npos)
            for (int i = currentRow.find(": ") + 2; i < currentRow.size(); i++)
                Expr += currentRow[i];
        else if (currentRow.find("postFix") != std::string::npos)
            for (int i = currentRow.find(": ") + 2; i < currentRow.size(); i++)
                Pstf += currentRow[i];
        else if (currentRow.find("Result") != std::string::npos)
            for (int i = currentRow.find(": ") + 2; i < currentRow.size(); i++)
                Res += currentRow[i];
    }
    file.close();
}

int getEditDistance(std::string first, std::string second)
{
    const int m = first.length();
    const int n = second.length();

    int** T = new int* [m + 1];
    for (int i = 0; i <= m; i++)
        T[i] = new int[n + 1];
    T[0][0] = 0;

    for (int i = 1; i <= m; i++)
        T[i][0] = i;
    for (int j = 1; j <= n; j++)
        T[0][j] = j;

    for (int i = 1; i <= m; i++)
        for (int j = 1; j <= n; j++)
        {
            int weight = first[i - 1] == second[j - 1] ? 0 : 1;
            T[i][j] = std::min(std::min(T[i - 1][j] + 1, T[i][j - 1] + 1), T[i - 1][j - 1] + weight);
        }

    return T[m][n];
}

double findStringSimilarity(std::string first, std::string second)
{
    double max_length = std::max(first.length(), second.length());
    if (max_length > 0)
    {
        return (max_length - getEditDistance(first, second)) / max_length;
    }
    return 1.;
}

void Math::CheckMap(std::string search)
{
    lastSearch = search;
    std::map<std::string, double>::const_iterator mapIt = similarity.begin();
    mapIt = similarity.find(search);
    if (mapIt == similarity.end())
        similarity[search] = findStringSimilarity(sExpression, search);
}
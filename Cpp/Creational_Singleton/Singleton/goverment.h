#ifndef GOVERMENT_H
#define GOVERMENT_H

#include <iostream>
using namespace std;

class Goverment
{
private:
    static Goverment* instance;

private:
    Goverment();

public:
    static Goverment* getInstance();
};

#endif // GOVERMENT_H

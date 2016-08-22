#include "goverment.h"

Goverment* Goverment::instance = NULL;

Goverment::Goverment()
{
    cout << "Constructor!" <<endl;
}

Goverment *Goverment::getInstance()
{
    if(Goverment::instance == NULL)
        Goverment::instance = new Goverment();
    return Goverment::instance;
}

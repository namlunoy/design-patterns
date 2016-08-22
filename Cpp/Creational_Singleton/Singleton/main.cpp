#include <iostream>
#include "goverment.h"

using namespace std;

int main(int argc, char *argv[])
{
    system("clear");

    // Can not crate an instance
    // Goverment g;

    Goverment* g1 = Goverment::getInstance();
    Goverment* g2 = Goverment::getInstance();

    if(g1 == g2)
        cout<<"It's the same!x"<<endl;

    return 0;
}

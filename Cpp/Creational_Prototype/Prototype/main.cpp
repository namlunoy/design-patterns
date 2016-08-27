#include <iostream>
#include "basecar2.h"

using namespace std;

int main(int argc, char *argv[])
{
    system("clear");

    BaseCar2 a;
    a.value = -2;

    // BaseCar2* b = a.clone();
    BaseCar2* b = a.deepCopy();

    if(a.data == b->data ){
        cout << "The same!" <<endl;
    }else{
        cout << "Difference!"<<endl;
    }

    return 0;
}

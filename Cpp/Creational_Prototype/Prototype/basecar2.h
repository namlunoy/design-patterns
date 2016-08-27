#ifndef BASECAR2_H
#define BASECAR2_H

#include <iostream>
#include "deepdata.h"

using namespace std;

class BaseCar2
{
public:
    int value;
    DeepData* data;
    BaseCar2(){
           cout <<"constructor!"<<endl;
           data = new DeepData();
           data->value = 1;
    }

    BaseCar2* clone(){
        BaseCar2* newCar = new BaseCar2(*this);
        return newCar;
    }

    BaseCar2* deepCopy(){
        BaseCar2* newCar = this->clone();
        newCar->data = new DeepData();
        return newCar;
    }
};

#endif // BASECAR2_H

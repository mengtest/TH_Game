#include <string>
#include "sol/sol.hpp"

class GamePlay
{
private:
    /* data */
public:
    static sol::state * _lua;

    GamePlay(/* args */);
    
    ~GamePlay();

    double call(double x, double y);

    const char * func(const std::string& name);
};

compose = lambda f, g: lambda x: f( g(x) )
from math import sin, asin
sin_asin = compose(sin, asin)
print sin_asin(0.5)
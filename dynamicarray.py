import ctypes # creates datatypes from c programming 
class List:
    def __init__(self):
        self.size=1
        self.n=0
        self.A=self.__make_array(self.size)
    def __make_array(self,capacity):
        # creates a c type array with size capacity
        return (capacity*ctypes.py_object)()
L = List() #creates a instance of list
print(type(L)) #prints the type
print(L) #prints the address where it is located
        

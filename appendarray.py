import ctypes # creates datatypes from c programming 

class List:
    def __init__(self):
        self.size=1
        self.n=0
        self.A=self.__make_array(self.size)
        
    def __len__(self):
        return self.n 
        
    def append(self,item):
        if self.n == self.size:
            self.__resize(self.size*2)#resize
        
        self.A[self.n]=item #append
        self.n=self.n+1
    
    def __resize(self,new_capacity):
        B=self.__make_array(new_capacity) #create new array with new capacity 
        self.size=new_capacity 
    
    for i in range(self.n): #copy the content of A to B 
        B[i]=self.A[i]
    
    self.A=B # reassign A
        
    def __make_array(self,capacity):
        # creates a c type array with size capacity
        return (capacity*ctypes.py_object)()
        
L = List() #creates a instance of list
print(type(L)) #prints the type
print(L) #prints the address where it is located

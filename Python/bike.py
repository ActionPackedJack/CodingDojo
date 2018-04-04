class bike(object):
    def __init__(self, price, max_speed, miles=0):
        self.price=price
        self.max_speed=max_speed
        self.miles=miles
    def displayInfo(self):
        print "Price: $" + str(self.price) + " maximum speed:" + str(self.max_speed) + " mileage:" + str(self.miles)
        return self
    def ride(self):
        print "Riding..."
        self.miles+=10
        print "Mileage is now "+str(self.miles)
        return self
    def reverse(self):
        print "Reverse!  Reverse!"
        self.miles-=5
        if self.miles<0:
            self.miles=0
        print "Mileage is now "+str(self.miles)
        return(self)
bike1=bike(200,"20 mph")
bike2=bike(70, "12 mph", 42)
bike3=bike(11,"2 mph",7000)
bike1.displayInfo().ride().reverse().reverse().reverse()
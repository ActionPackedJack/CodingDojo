class product(object):
    def __init__(self, price, name, weight, brand, status="for sale"):
        self.price=price
        self.name=name
        self.weight=weight
        self.brand=brand
        self.status=status
    def sell(self):
        self.status="sold"
        return self
    def addTax(self, tax):
        self.price=float(self.price)+float(1+self.price*tax)
        return self
    def returns(self, reason):
        if reason=="defective":
            self.status="defective"
            self.price=0
        if reason== "opened":
            self.status="used"
            self.price*=0.8
        if reason== "like new":
            self.status="for sale"
        return self
    def displayInfo(self):
        print "Name: "+ str(self.name)
        print "Price: $"+ str(self.price)
        print "Brand: " + str(self.brand)
        print "Weight: " + str(self.weight) + "kg"
        print "Status: "+ str(self.status)
        return self

onlyThingForSale=product(200,"Murder",150,"Chicago Classic")
onlyThingForSale.displayInfo().sell().addTax(0.9).displayInfo().returns("defective").displayInfo()


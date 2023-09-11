class plane:
    def __init__(self):
        self.speed=100
        self.isMoving=True
        self.color="blue"
        self.passengers=256

    def stop(self):
        self.isMoving=False

    def acccelerate(self,amount):
        self.speed+=amount
        self.isMoving=self.speed!=0

    def printSpeed(speed):
        print("The speed is ",self.speed," km/h")
    
    def increasePassengers(self,amount):
        self.passengers+=amount

    def printNumberPassengers(self):
        print("There are ", self.passengers, "passengers on the board")

    def printInTheAir(self):
        if self.isMoving:
            print("The plane is in the air")
        else:
            print("The plane has landed")
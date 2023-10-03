class Plane:
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

    def printSpeed(self,speed):
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

def main():
    plane=Plane()
    plane.printSpeed(plane.speed)
    plane.acccelerate(200)
    print("Speed after acceleration: ")
    plane.printSpeed(plane.speed)
    plane.increasePassengers(100)
    plane.printNumberPassengers()
    plane.printInTheAir()

if __name__=="__main__":
    main()

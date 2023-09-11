class diamond:
    def __init__(self):
        size=0
    
    def GiveTheSize(self):
        print("Give the size: ")
        self.size=int(input())
    
    def drawDiamond(self):
        for i in range(1, self.size + 1, 2):
            spaces = " " * ((self.size - i) // 2)
            stars = "*" * i
            print(spaces + stars)
        for i in range(self.size - 2, 0, -2):
            spaces = " " * ((self.size - i) // 2)
            stars = "*" * i
            print(spaces + stars)

def main():
    diamond_obj=diamond()
    diamond_obj.GiveTheSize()
    diamond_obj.drawDiamond()

if __name__ == "__main__":
    main()

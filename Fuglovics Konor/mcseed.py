import random
import os
import time

print("Minecraft Seed Generator")

on = True
while on:
        number = random.randint(-(2**63), (2**63)-1)
        generate = input("\nPress Enter to generate a seed!")
        if generate == "":
            print(number)
            os.system(f"echo {number}| clip")
            print("\nSeed copied!")
            after = input("")
            while after != "q":
                   print(f"Unknown command: {after}")
                   break
            else:
                print("Ending session...")
                time.sleep(1)
                on = False
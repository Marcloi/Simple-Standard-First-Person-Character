Created By Marcloi Rada Cardona
	This is a simple First Person Character 
		Camera movement
		-Player graphics can easily replaced by an actual humanoid
		-Horizontal camera movement is achived by rotating the player object in the y axis
		-Vertical camera movement is achieved by subtracting the mouse's Y coordinate to 0 and appliying it to the camera's X rotation axis
		
		Player movement
		-Using the CharacaterController.Move Method which takes a Vector3 Parameter and moves the character based on the direction and magnitude of the vector 
		-For simplicity we added a momentum vector to add gravity force to the player
		-The momentum vector can also be moodified just like in the Jump section of the code to simulate bumps and knockback effects 
		-If the user wants to implement a sprint function just make a if statement similar to the jump get input check but instead of using GetButtonDown just use GetButton
			E.G. 
				if (Input.GetButton("Fire3"))
				{
					movementSpeed = 7f;
				}
				else
				{
					movementSpeed = 5f;
				}

Asset Store Link = http://u3d.as/2FVZ

Thanks for supporting me!
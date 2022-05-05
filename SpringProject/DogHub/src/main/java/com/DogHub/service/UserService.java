package com.DogHub.service;

import com.DogHub.dto.Join;

public interface UserService {
	void join(Join join);
 
	int overlapCheck(String value, String valueType);
}


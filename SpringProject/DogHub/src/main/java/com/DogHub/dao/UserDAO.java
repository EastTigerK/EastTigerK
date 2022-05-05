package com.DogHub.dao;

import com.DogHub.dto.Join;

public interface UserDAO {
	void join(Join join);

	int overlapCheck(String value, String valueType);
}
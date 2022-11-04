UPDATE practicum 
SET 
    TotalHour = (SELECT 
            SUM(TotalHours)
        FROM
            attendance
        WHERE
            attendance.PracticumID = practicum.PracticumID)
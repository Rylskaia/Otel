CREATE PROCEDURE [dbo].[Procedure]

	@date01 datetime, 
	@date02 datetime
	
AS
	SELECT  Номер, Комплектация, Фото
FROM     Номер
WHERE  (Номер NOT IN
                      (SELECT Номер
                       FROM      [Бронирование номеров]
                       WHERE   ([Дата заселения] <= @date01) AND ([Дата Выезда] >= @date02) OR
                                         ([Дата заселения] <= @date01) AND ([Дата Выезда] >= @date02)))


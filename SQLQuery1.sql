SELECT w.Id, w.[Name], w.ImageUrl, w.NeighborhoodId, n.Name
                        FROM Walker w
                        JOIN Neighborhood n ON n.Id = w.NeighborhoodId
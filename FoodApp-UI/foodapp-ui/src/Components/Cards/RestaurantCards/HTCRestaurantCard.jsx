import { NavLink } from "react-router-dom";
import './HTCRestaurantCard.css'
const HTCRestaurantCard = ({item}) =>
{
    return(<>
    <div className="card">
        <div>
        <h3 className="restaurant-head">{item.name}, {item.rating} / 10 : {item.comment}</h3>
        <NavLink to={'/Dishes'} state ={{id : item.restaurantId, name : item.name}}><button className="dishes-btn">Rätter</button></NavLink>
        </div>

    </div>
    </>)
}
export default HTCRestaurantCard;
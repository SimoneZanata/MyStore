import { LoadingButton } from "@mui/lab";
import { Avatar, Button, Card, CardActions, CardContent, CardHeader, CardMedia, Typography } from "@mui/material";
import { Link } from "react-router-dom";
import { Product } from "../../app/models/product";
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { currencyFormat } from "../../app/util/util";
import { addBasketItemAsync } from "../basket/basketSlice";


interface Props {
    product: Product;
}

export default function ProductCard({ product }: Props) {
    const { status } = useAppSelector(state => state.basket);
    const dispatch = useAppDispatch();

    return (
        <Card sx={{ boxShadow: 5 }} >
            <CardHeader
                avatar={
                    <Avatar sx={{ bgcolor: 'secondary.main', boxShadow: 5 }}>
                        {product.name.charAt(0).toUpperCase()}
                    </Avatar>
                }
                title={product.name}
                titleTypographyProps={{
                    sx: { fontWeight: 'bold', color: 'primary.main' }
                }}
            />
            <CardMedia
                sx={{ height: 160, backgroundSize: 'contain', bgcolor: 'lightgrey'}}
                image={product.pictureUrl}
                title={product.name}
            />
            <CardContent>
                <Typography gutterBottom color='secondary' variant="h5">
                    {currencyFormat(product.price)}
                </Typography>
                <Typography variant="body2" color="text.secondary">
                    {product.brand} / {product.type}
                    <br />
                    {product.console}
                </Typography>
            </CardContent >
            <CardActions sx={{
                        '&:hover': {
                            color: 'grey.500',
                        },
                        '&.active': {
                            color: 'text.secondary',
                        },
                    }}>
                <LoadingButton
                    loading={status.includes('pendingAddItem' + product.id)}
                    onClick={() => dispatch(addBasketItemAsync({ productId: product.id }))}
                    size="medium"
                    sx={{
                        '&:hover': {
                            color: 'grey.500',
                        },
                        '&.active': {
                            color: 'text.secondary',
                        },
                    }}>            
                    Add to Cart
                </LoadingButton>

                <Button component={Link} to={`/catalog/${product.id}`} size="medium"
                sx={{
                    '&:hover': {
                        color: 'grey.500',
                    },
                    '&.active': {
                        color: 'text.secondary',
                    },
                }}>View</Button>
            </CardActions>
        </Card>
    )
}
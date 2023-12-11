import {ShoppingCart } from "@mui/icons-material";
import { Container, Button, Typography } from "@mui/material";
import { Link } from "react-router-dom";

export default function BasketEmpty() {
    return (
        <Container style={{ display: "flex", flexDirection: "column", alignItems: "center", justifyContent: "center" }} >
            <ShoppingCart style={{ fontSize: 350 }} />
            <Typography
                variant="h4"
                fontWeight={'bold'}
                style={{ textShadow: '2px 2px 4px rgba(0, 0, 0, 0.1)' }}>
                Your basket is still empty...
            </Typography>
            <Button
                variant="contained"
                component={Link}
                to='/catalog'
                style={{ marginTop: "25px" }}>
                Go back to the shop
            </Button>
        </Container>
    );
}



































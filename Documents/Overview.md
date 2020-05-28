# Handover

So, this project should have everything you need to maintain the basket and checkout. A few bits of information for you: 

- This speaks to three schemas (customer, basket and payment records).
- It also talks to our payment providor WirePay.

I'll give you a brief overview of what the code does.

## Basket

- You can `get` a basket from a basket id.
- You can `post` to add an item to the basket.
- You can `delete` an item from a basket.

## Checkout

- You can `get` the current value of the basket, with VAT applied.
- You can `put` to take a payment.

All pretty simple. Shouldn't be too hard to look after.
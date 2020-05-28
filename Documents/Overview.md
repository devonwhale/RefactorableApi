# Handover

So, this project should have everything you need to maintain the basket and checkout. A few bits of information for you: 

- This speaks to three schemas (customer, basket and payment records).
- It also talks to our payment providor WirePay.

I'll give you a brief overview of what the code does.

## Basket

- You can `get` a basket from a basket id.
- You can `patch` to add an item to the basket.
- You can `delete` an item from a basket.

## Checkout

- You can `get` the current value of the basket, with VAT applied.
- You can `put` to take a payment. Gives you back a true or false depending on whether the payment was successful.

All pretty simple. Shouldn't be too hard to look after.

## Know issues

Okay, fine, so there are a couple of know issues. 

- Sometimes, the final price is a penny off when you call the `get` endpoint on `Checkout`.

## Things that look like issues but aren't

- Removing something from a basket removes all copies of it. This is intentional as the front end doesn't support removing individual items.